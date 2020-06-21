using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga2_Tkalcic.Models
{
    public static class Seed
    {
        public static async Task CreateInitialUserAndRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<Uporabnik>>();
            var roles = new string[] { "Admin", "User" };
            IdentityResult roleResult;

            foreach(var data in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(data);
                if(roleExist == false)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(data));
                }
            }

            var uporabniskoIme = "rok.tkalcic@student.um.si";
            var admin = new Uporabnik
            {
                Ime = "Rok",
                Priimek = "Tkalcic",
                DatumRojstva = new DateTime(1999, 6, 11),
                KrajRojstva = "Maribor",
                EMSO = "1006999500176",
                Starost = 20,
                Naslov = "Bevkova 3",
                Drzava = "Slovenija",
                Email = uporabniskoIme,
                UserName = uporabniskoIme,
                EPosta = uporabniskoIme,
                Posta = "Maribor",
                PostnaStevilka = 2000
            };

            var adminPass = "Admin123?";

            var _uporabnik = await userManager.FindByNameAsync(uporabniskoIme);

            if(_uporabnik == null)
            {
                try
                {
                    var createAdmin = await userManager.CreateAsync(admin, adminPass);
                    if (createAdmin.Succeeded)
                    {
                        try
                        {
                            var result = await userManager.AddToRoleAsync(admin, "Admin");
                            result = await userManager.AddToRoleAsync(admin, "User");
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                    }
                }
                catch(Exception e)
                {
                    throw e;
                    
                }
                
                
            }
        }
    }
}
