using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Medolai.Database.Migrations
{
    /// <inheritdoc />
    public partial class db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T1",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    P2T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P3T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P4T1 = table.Column<int>(type: "integer", nullable: true),
                    P5T1 = table.Column<int>(type: "integer", nullable: true),
                    P6T1 = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    P7T1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    P8T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P10T1 = table.Column<int>(type: "integer", nullable: true),
                    P12T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P14T1 = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    P17T1 = table.Column<int>(type: "integer", nullable: true),
                    P18T1 = table.Column<decimal>(type: "numeric", nullable: true),
                    P19T1 = table.Column<int>(type: "integer", nullable: true),
                    P21T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P22T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P23T1 = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    P25T1 = table.Column<int>(type: "integer", nullable: true),
                    P26T1 = table.Column<int>(type: "integer", nullable: true),
                    P27T1 = table.Column<int>(type: "integer", nullable: true),
                    P29T1 = table.Column<int>(type: "integer", nullable: true),
                    P30T1 = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    P31T1 = table.Column<int>(type: "integer", nullable: true),
                    P32T1 = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: true),
                    P37T1 = table.Column<decimal>(type: "numeric", nullable: true),
                    P38T1 = table.Column<int>(type: "integer", nullable: true),
                    P39T1 = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    P40T1 = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    P41T1 = table.Column<int>(type: "integer", nullable: true),
                    P42T1 = table.Column<int>(type: "integer", nullable: true),
                    P44T1 = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    P48T1 = table.Column<int>(type: "integer", nullable: true),
                    P53T1 = table.Column<int>(type: "integer", nullable: true),
                    P57T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P58T1 = table.Column<decimal>(type: "numeric", nullable: true),
                    P59T1 = table.Column<decimal>(type: "numeric", nullable: true),
                    P61T1 = table.Column<int>(type: "integer", nullable: true),
                    P63T1 = table.Column<int>(type: "integer", nullable: true),
                    P64T1 = table.Column<int>(type: "integer", nullable: true),
                    P67T1 = table.Column<int>(type: "integer", nullable: true),
                    P87T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P96T1 = table.Column<int>(type: "integer", nullable: true),
                    P97T1 = table.Column<int>(type: "integer", nullable: true),
                    P98T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P99T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P115T1 = table.Column<decimal>(type: "numeric", nullable: true),
                    P221T1 = table.Column<int>(type: "integer", nullable: true),
                    P222T1 = table.Column<int>(type: "integer", nullable: true),
                    P240T1 = table.Column<int>(type: "integer", nullable: true),
                    P244T1 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P_IMPORTER_EMAIL = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    P_IMPORTER_PHONE = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_t1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T2",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    T1_ID = table.Column<long>(type: "bigint", nullable: false),
                    P3T2 = table.Column<int>(type: "integer", nullable: true),
                    P4T2 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    P5T2 = table.Column<int>(type: "integer", nullable: true),
                    P8T2 = table.Column<int>(type: "integer", nullable: true),
                    P9T2 = table.Column<long>(type: "bigint", nullable: true),
                    P10T2 = table.Column<int>(type: "integer", nullable: true),
                    P11T2 = table.Column<decimal>(type: "numeric", nullable: true),
                    P13T2 = table.Column<int>(type: "integer", nullable: true),
                    P16T2 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P17T2 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P18T2 = table.Column<decimal>(type: "numeric", nullable: true),
                    P21T2 = table.Column<decimal>(type: "numeric", nullable: true),
                    P22T2 = table.Column<decimal>(type: "numeric", nullable: true),
                    P23T2 = table.Column<int>(type: "integer", nullable: true),
                    P25T2 = table.Column<decimal>(type: "numeric", nullable: true),
                    P26T2 = table.Column<decimal>(type: "numeric", nullable: true),
                    P30T2 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P37T2 = table.Column<decimal>(type: "numeric", nullable: true),
                    P213T2 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P214T2 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_t2", x => x.ID);
                    table.ForeignKey(
                        name: "fk_t2_t1_t1_id",
                        column: x => x.T1_ID,
                        principalTable: "T1",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T4",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    T2_ID = table.Column<long>(type: "bigint", nullable: false),
                    P3T4 = table.Column<int>(type: "integer", nullable: true),
                    P4T4 = table.Column<decimal>(type: "numeric", nullable: true),
                    P5T4 = table.Column<decimal>(type: "numeric", nullable: true),
                    P6T4 = table.Column<decimal>(type: "numeric", nullable: true),
                    P7T4 = table.Column<int>(type: "integer", nullable: true),
                    P8T4 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P9T4 = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_t4", x => x.ID);
                    table.ForeignKey(
                        name: "fk_t4_t2_t2_id",
                        column: x => x.T2_ID,
                        principalTable: "T2",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T7",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    T2_ID = table.Column<long>(type: "bigint", nullable: false),
                    P3T7 = table.Column<int>(type: "integer", nullable: true),
                    P4T7 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    P5T7 = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_t7", x => x.ID);
                    table.ForeignKey(
                        name: "fk_t7_t2_t2_id",
                        column: x => x.T2_ID,
                        principalTable: "T2",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T9",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    T2_ID = table.Column<long>(type: "bigint", nullable: false),
                    P4T9 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P6T9 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P7T9 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    P8T9 = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    P12T9 = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    P200T9 = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_t9", x => x.ID);
                    table.ForeignKey(
                        name: "fk_t9_t2_t2_id",
                        column: x => x.T2_ID,
                        principalTable: "T2",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_t2_t1_id",
                table: "T2",
                column: "T1_ID");

            migrationBuilder.CreateIndex(
                name: "ix_t4_t2_id",
                table: "T4",
                column: "T2_ID");

            migrationBuilder.CreateIndex(
                name: "ix_t7_t2_id",
                table: "T7",
                column: "T2_ID");

            migrationBuilder.CreateIndex(
                name: "ix_t9_t2_id",
                table: "T9",
                column: "T2_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T4");

            migrationBuilder.DropTable(
                name: "T7");

            migrationBuilder.DropTable(
                name: "T9");

            migrationBuilder.DropTable(
                name: "T2");

            migrationBuilder.DropTable(
                name: "T1");
        }
    }
}
