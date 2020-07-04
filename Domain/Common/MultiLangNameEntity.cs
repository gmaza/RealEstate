using Domain.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Domain.Common
{
    public abstract class MultiLangNameEntity
    {
        public int Id { get; set; }
        public string NameEN { get; set; }
        public string NameRU { get; set; }
        public string NameCZ { get; set; }

        public string GetLocalizedName()
        {
            string name = NameEN;
            string culture = Thread.CurrentThread.CurrentCulture.Name;

            name = culture switch
            {
                "cs-CZ" => NameCZ,
                "cu-RU" => NameRU,
                "en-US" => NameEN,
                _ => NameEN,
            };

            return name;
        }
    }
}
