using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCRUD.Migrations {
	/// <inheritdoc />
	public partial class Initial :Migration {
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder) {
			migrationBuilder.CreateTable(
				name: "Student",
				columns: table => new {
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Age = table.Column<int>(type: "int", nullable: false),
					Birthday = table.Column<DateTime>(type: "datetime2", nullable: true)
				},
				constraints: table => {
					table.PrimaryKey("PK_Student", x => x.Id);
				});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder) {
			migrationBuilder.DropTable(
				name: "Student");
		}
	}
}
