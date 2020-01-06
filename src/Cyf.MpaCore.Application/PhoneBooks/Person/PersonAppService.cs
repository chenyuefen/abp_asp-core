using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Cyf.MpaCore.PhoneBooks.Person.Dto;
using Microsoft.EntityFrameworkCore;

namespace Cyf.MpaCore.PhoneBooks.Person
{
    public class PersonAppService : MpaCoreAppServiceBase, IPersonAppService
    {

        private readonly IRepository<Persons.Person> _personRepository;


        public PersonAppService(IRepository<Persons.Person> personRepository)
        {
            _personRepository = personRepository;
        }




        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("该联系人已经消失在数据库中，无法二次删除");
            }
            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personRepository.GetAllIncluding(a => a.PhoneNumbers);
            var personCount = await query.CountAsync();
            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var dtos = ObjectMapper.Map<List<PersonListDto>>(persons);            
            return new PagedResultDto<PersonListDto>(personCount, dtos);
        }


        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var person = await _personRepository.GetAllIncluding(a => a.PhoneNumbers).FirstOrDefaultAsync(a => a.Id == input.Id.Value);
            return ObjectMapper.Map<PersonListDto>(person);

        }



        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id.Value);
            await _personRepository.UpdateAsync(ObjectMapper.Map<Persons.Person>(input));
        }

        protected async Task CreatePersonAsync(PersonEditDto input)
        {
            var entity = ObjectMapper.Map<Persons.Person>(input);
            await _personRepository.InsertAsync(entity);
        }



        public async Task<GetPersonForEditOutput> GetPersonForEditAsync(NullableIdDto<int> input)
        {
            var output = new GetPersonForEditOutput();
            PersonEditDto personEditDto;
            if (input.Id.HasValue)
            {
                var entity = await _personRepository.GetAllIncluding(a => a.PhoneNumbers).FirstOrDefaultAsync(a => a.Id == input.Id.Value);
                personEditDto = ObjectMapper.Map<PersonEditDto>(entity);
            }
            else
            {
                personEditDto = new PersonEditDto();
            }
            output.Person = personEditDto;
            return output;
        }
    }
}
