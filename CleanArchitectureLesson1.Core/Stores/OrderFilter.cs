using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureLesson1.Core.Stores
{
    public record OrderFilter(
        IEnumerable<Guid> Ids,
        IEnumerable<string> Names,
        IEnumerable<DateTime> Dates);
}
