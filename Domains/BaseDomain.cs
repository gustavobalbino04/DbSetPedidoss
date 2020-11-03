using System;
using System.ComponentModel.DataAnnotations;

namespace DbSetPedidos.Domains
{
    //abstract - deixa seu cod mais seguro, pois nao vai consegui estanciar essa classe 
    public  abstract class BaseDomain
    {
        [Key]

        public Guid Id { get; private  set; }
        public BaseDomain()
        {
            Id = Guid.NewGuid();
        }
    }
}