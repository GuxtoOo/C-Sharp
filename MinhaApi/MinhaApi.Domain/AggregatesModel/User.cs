using MinhaApi.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApi.Domain.AggregatesModel
{
    public class User : Entity
    {
        public string Name { get; private set; }
        public string Document { get; private set; }

        protected User() { }

        public User(string name, string document)
        {
            Name = name;
            Document = document;
        }
    }
}
