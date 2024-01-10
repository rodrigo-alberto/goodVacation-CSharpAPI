using CSharpAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpAPI.Data
{
   
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Destiny> Destinys { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Destiny>().HasData(
        new Destiny { 
          Id = 1, 
          Name = "Cachoeira do Mosquito", 
          City = "Lençois", State = "Bahia", 
          Description = "Com uma bela queda d’água em meio a grandiosos paredões rochosos, a Cachoeira do Mosquito impressiona pela sua beleza e graciosidade natural.",
          ImageUrls = [
            "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/e21efdfa-1b3e-4ad7-ac47-561e304f33c4",
            "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/18274ddb-11b5-4c65-a006-dee24aa1e78f"
          ] 
        },
        new Destiny {
          Id = 2, 
          Name = "Ilha Grande", 
          City = "Angra dos Reis", 
          State = "Rio de Janeiro", 
          Description = "Um sítio histórico e natural com mais de 100 praias, além de cachoeiras, rios, trilhas, construções históricas e uma rica flora e fauna.", 
          ImageUrls = [
            "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/0fe9f6d6-a3ab-4691-bda6-94bddfd922f7", 
            "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/5a2b541d-4d6c-4fff-9725-9f85f22cadfe"
          ] 
        },
        new Destiny {
          Id = 3, 
          Name = "Praia de Atalaia", 
          City = "Aracaju", 
          State = "Sergipe", 
          Description = "Aracaju é um destino que reúne um extenso litoral, praias de rio, centro histórico repleto de museus e mercados públicos, além de uma culinária deliciosa.", 
          ImageUrls = [
            "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/d89a7598-da08-4fe4-802c-d45b60f9f8be", 
            "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/70027f1a-ca8f-410f-bbfd-3840caa805a8"
          ] 
        },
        new Destiny {
          Id = 4, 
          Name = "Pratinha", 
          City = "Iraquara", 
          State = "Bahia", 
          Description = "As águas cristalinas do rio Pratinha são um convite para uma pedalada em família, um teste de equilíbrio ou remo em meio à natureza.", 
          ImageUrls = [
            "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/3bdddeb1-7f26-4897-b62c-aafbe38f136c", 
            "https://github.com/rodrigo-alberto/goodVacation-CSharpAPI/assets/85527665/c50c9cc7-d752-4705-981f-33f27359a9bc"
          ] 
        }
      );
    } 
  } 
}