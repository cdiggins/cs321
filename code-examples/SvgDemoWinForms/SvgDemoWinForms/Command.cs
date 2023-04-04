using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvgDemoWinForms
{
    public enum EditType
    {
        Add,
        Insert,
        Delete
    }

    public class CommandRecord
    {
        public DateTime When { get; set; }  
        public EditType EditType { get; set; }
        public List<Element> ModifiedElements { get; set; }
    }

    public class Controller
    {

    }

    public class UndoItem
    {
        public SvgDocument PreviousState { get; }
        public SvgDocument NextState { get; }
    }

}
