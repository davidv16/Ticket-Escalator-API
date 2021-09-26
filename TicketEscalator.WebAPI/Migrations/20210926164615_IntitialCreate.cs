using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketEscalator.WebAPI.Migrations
{
    public partial class IntitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SerialNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Usage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PartsNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    SSN = table.Column<string>(type: "TEXT", nullable: true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSparePart",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "INTEGER", nullable: false),
                    SparePartsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSparePart", x => new { x.ProductsId, x.SparePartsId });
                    table.ForeignKey(
                        name: "FK_ProductSparePart_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSparePart_SpareParts_SparePartsId",
                        column: x => x.SparePartsId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerContacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerContacts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExtraItems = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerContacted = table.Column<bool>(type: "INTEGER", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReadyDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatorID = table.Column<int>(type: "INTEGER", nullable: false),
                    AssigneeID = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "Assignee_FK",
                        column: x => x.AssigneeID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "Creator_FK",
                        column: x => x.CreatorID,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTicket",
                columns: table => new
                {
                    ProductsId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTicket", x => new { x.ProductsId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_ProductTicket_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Repairs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    DaytimeHours = table.Column<double>(type: "REAL", nullable: false),
                    OvertimeHours = table.Column<double>(type: "REAL", nullable: false),
                    Trip = table.Column<int>(type: "INTEGER", nullable: false),
                    RepairDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repairs_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SparePartTicket",
                columns: table => new
                {
                    SparePartsId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SparePartTicket", x => new { x.SparePartsId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_SparePartTicket_SpareParts_SparePartsId",
                        column: x => x.SparePartsId,
                        principalTable: "SpareParts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SparePartTicket_Tickets_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeRepair",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "INTEGER", nullable: false),
                    RepairsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRepair", x => new { x.EmployeesId, x.RepairsId });
                    table.ForeignKey(
                        name: "FK_EmployeeRepair_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRepair_Repairs_RepairsId",
                        column: x => x.RepairsId,
                        principalTable: "Repairs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_CustomerId",
                table: "CustomerContacts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ProductId",
                table: "Customers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRepair_RepairsId",
                table: "EmployeeRepair",
                column: "RepairsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSparePart_SparePartsId",
                table: "ProductSparePart",
                column: "SparePartsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTicket_TicketsId",
                table: "ProductTicket",
                column: "TicketsId");

            migrationBuilder.CreateIndex(
                name: "IX_Repairs_TicketId",
                table: "Repairs",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_SparePartTicket_TicketsId",
                table: "SparePartTicket",
                column: "TicketsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AssigneeID",
                table: "Tickets",
                column: "AssigneeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CreatorID",
                table: "Tickets",
                column: "CreatorID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CustomerId",
                table: "Tickets",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerContacts");

            migrationBuilder.DropTable(
                name: "EmployeeRepair");

            migrationBuilder.DropTable(
                name: "ProductSparePart");

            migrationBuilder.DropTable(
                name: "ProductTicket");

            migrationBuilder.DropTable(
                name: "SparePartTicket");

            migrationBuilder.DropTable(
                name: "Repairs");

            migrationBuilder.DropTable(
                name: "SpareParts");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
