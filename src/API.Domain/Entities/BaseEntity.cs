using System;
using System.ComponentModel.DataAnnotations;

namespace API.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        //? pode receber nulo
        private DateTime? _createAt;
        public DateTime? MyProperty
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); } // se for nulo, createAt recebe UtcNow (que é o que tá configurado no servidor)Obtém um objeto DateTime definido como a data e hora atual neste computador, expressas como o UTC (Tempo Universal Coordenado).
        }

        public DateTime UpdateAt { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
