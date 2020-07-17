using System;
using application.Contracts;

namespace application.Models
{
    public abstract class ModelBase: IModel
    {
        protected ModelBase(){
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
    }
}