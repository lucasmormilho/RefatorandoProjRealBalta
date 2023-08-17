
using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
    public class Utm
    {
        //public Url Url { get; set; } = new(); //já instancia para tirar o nullable
        //public Campaign Campaign { get; set; } = null!; //não pode ser nulo mas não tenho valores agora
        //mas usar no construtor essa regra

        public Utm(Url url, Campaign campaign)
        {
            Url = url;
            Campaign = campaign;
        }

        /// <summary>
        /// URL (Wesite link)
        /// </summary>
        public Url Url { get; }

        /// <summary>
        /// Campaign Details
        /// </summary>
        public Campaign Campaign { get; init; }

        public override string ToString()
        {
            //benchmark.net para testar velocidade
            var segments = new List<string>();
            segments.AddIfNotNull();
            return $"{Url.Address}?{string.Join("&", segments)}";
        }

    }
}