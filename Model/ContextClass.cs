using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demopract2024_2.Model
{
    public partial class ContextClass:Model.DemopracContext
    {
        Model.DemopracContext context { get; } = new Model.DemopracContext();
    }
}
