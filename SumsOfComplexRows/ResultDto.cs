using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsOfComplexRows
{
    public class ResultDto
    {
        public string SchoolName { get; set; }
        public List<ResultRowDto> ClassRoomCounts { get; set; }
    }
}
