using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns._4_Builder
{
    class Person
    {
        internal void SetBody()
        {
            throw new NotImplementedException();
        }

        internal void SetHead()
        {
            throw new NotImplementedException();
        }

        internal void SetFoot()
        {
            throw new NotImplementedException();
        }

        string GetBody()
        {
            return body;
        }

        string GetHead()
        {
            return head;
        }

        string GetFoot()
        {
            return foot;
        }

        private string head;
        private string body;
        private string foot;
    }
}
