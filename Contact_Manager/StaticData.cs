using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager
{
    /**
     * Defines all static data over the whole application
     */
    public static class StaticData
    {
        /**
         * Defines the countries
         */
        public static readonly string[] Countries =
        {
            "Schweiz",
            "Deutschland",
            "Liechtenstein",
            "Frankreich",
            "Österreich",
            "Italien"
        };

        /**
         * Defines all titles
         */
        public static readonly string[] Titles =
        {
            "",
            "Dr.",
            "Dr. Dr.",
            "Dr. hc",
            "Dr. Ing.",
            "Dr. med. dent.",
            "Dr. med. vet",
            "Dr. phil",
            "Ing.",
            "Notar",
            "Notarin",
            "Prof.",
            "Prof. Dr.",
            "Prof. Dr. med.",
            "Prof. Dr. med. vet",
            "Rechtsanwalt",
            "Rechtsanwältin",
            "Dr. rer. nat.",
            "Dr. jur.",
            "Prof. Dr. rer. nat.",
            "Dr. iur.",
            "Dr. phil. nat.",
            "Dr. rer. pol.",
            "Dr. oec."
        };

        /**
         * Defines all salutations
         */
        public static readonly string[] Salutations =
        {
            "Herr",
            "Frau"
        };

        /**
         * Defines all management levels
         */
        public static readonly string[] ManagementLevels =
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"
        };

        /**
         * Defines all level of employments
         */
        public static readonly string[] Loes =
        {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "100"
        };
    }
}
