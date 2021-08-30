using System.Runtime.Serialization;

namespace ExercicioDSD
{
    [DataContract]
    public class AnimaisResgatados
    {      

        [DataMember(Name = "Nome")]
        public string Nome { get; set; }

        [DataMember(Name = "TipoDeAnimal")]
        public string TipoDeAnimal { get; set; }

        [DataMember(Name = "AustrPaisOrigemalia")]
        public string PaisOrigem { get; set; }

        [DataMember(Name = "QuantidadeEncontrada")]
        public int QuantidadeEncontrada { get; set; }
    }
}
