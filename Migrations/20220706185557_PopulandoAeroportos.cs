using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiBuscaVoos.Migrations
{
    public partial class PopulandoAeroportos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Aeroportos (Nome,Sigla,Cidade) VALUES "+
"('Aeroporto Internacional Juscelino Kubitschek', 'BSB', 'Brasília'),"+
"('Aeroporto Eurico de Aguiar Salles', 'VIX', 'Vitória'), "+
"('Aeroporto Internacional Zumbi dos Palmares', 'MCZ', 'Maceió'), " +
"('Aeroporto Internacional de Belém de Cans', 'BEL', 'Belém'), " +
"('Aeroporto Internacional Hercílio Luz', 'FLN', 'Florianópolis'), " +
"('Aeroporto de Congonhas Paulo', 'CGH', 'São Paulo'), " +
"('Aeroporto Internacional de Aracaju', 'AJU', 'Aracaju'), " +
"('Aeroporto Internacional de Viracopos', 'VCP', 'Campinas'), " +
"('Aeroporto de Palmas', 'PMW', 'Palmas'), " +
"('Aeroporto da Pampulha', 'PLU', 'Belo Horizonte');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE * from Aeroportos;");
        }
    }
}
