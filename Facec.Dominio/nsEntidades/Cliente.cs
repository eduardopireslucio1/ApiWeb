using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Facec.Dominio.nsEntidades
{
    public class Cliente
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("documento")]
        public string Documento { get; set; }
    }
}
