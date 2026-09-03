using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookRight.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIntroduktionssamtale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Behandlingstyper",
                columns: new[] { "BehandlingstypeId", "KrævetAutorisationsType", "Navn", "Pris", "Type", "VarighedMinutter" },
                values: new object[] { new Guid("aaaaaaaa-0010-0000-0000-000000000000"), 4, "Introduktionssamtale", 0m, 5, 15 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Behandlingstyper",
                keyColumn: "BehandlingstypeId",
                keyValue: new Guid("aaaaaaaa-0010-0000-0000-000000000000"));
        }
    }
}
