using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models.SwitchTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Assamblers
{
    public class TeacherTeachInSchoolClassAssambler : Assambler<TeacherTeachInSchoolClass, TeacherTeachInSchoolClassDto>
    {
        public override TeacherTeachInSchoolClassDto ToDto(TeacherTeachInSchoolClass domainEntity)
        {
            return new TeacherTeachInSchoolClassDto();
        }

        public override TeacherTeachInSchoolClass ToModel(TeacherTeachInSchoolClassDto dto)
        {
            return new TeacherTeachInSchoolClass();
        }
    }
}
