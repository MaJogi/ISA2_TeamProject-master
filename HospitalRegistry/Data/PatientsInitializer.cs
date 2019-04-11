using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HospitalRegistry.Data
{
    public static class PatientsInitializer
    {
        public static void Initialize(RegistryContext c)
        {
            c.Database.EnsureCreated();
            if (c.Patients.Any()) return;

            //I don't understand what the following code does...
            var cultures = CultureInfo
                .GetCultures(CultureTypes.SpecificCultures)
                .Select(i => new RegionInfo(i.LCID))
                .Distinct()
                .ToList();

            //I don't understand what the following code does...
            //var regions = cultures.OrderBy(p => p.EnglishName).ToList();

            //foreach (var r in regions)
            //{
            //    var id = r.ThreeLetterISORegionName;
            //    if (char.IsNumber(id[0])) continue;
            //    var name = r.DisplayName;
            //    var code = r.TwoLetterISORegionName;
            //    var e = new IsoCountry(id, name, code);
            //    c.Countries.Add(e);
            //    c.SaveChanges();
            //}
        }
    }
}
