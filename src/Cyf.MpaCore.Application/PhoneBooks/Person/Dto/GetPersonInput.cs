using Abp.Runtime.Validation;
using Cyf.MpaCore.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cyf.MpaCore.PhoneBooks.Person.Dto
{
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public string FilterText { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
