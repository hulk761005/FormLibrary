using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLibrary
{
    public class FormFactory : IFormFactory
    {
        string _assName;
        public FormFactory(string assName)
        {
            _assName = assName;
        }
        public virtual Form CreateForm(string formName)
        {
            string className = _assName + "." + formName;
            return (Form)Assembly.Load(_assName).CreateInstance(className);
        }
    }
}
