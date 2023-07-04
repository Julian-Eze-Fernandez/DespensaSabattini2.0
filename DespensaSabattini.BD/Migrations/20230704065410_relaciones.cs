﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DespensaSabattini.BD.Migrations
{
    /// <inheritdoc />
    public partial class relaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RolId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagoId",
                table: "TipoPagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagoId",
                table: "Proveedores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Monto",
                table: "Pagos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoPagos_PagoId",
                table: "TipoPagos",
                column: "PagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_PagoId",
                table: "Proveedores",
                column: "PagoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_UsuarioId",
                table: "Pagos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Usuarios_UsuarioId",
                table: "Pagos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Pagos_PagoId",
                table: "Proveedores",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoPagos_Pagos_PagoId",
                table: "TipoPagos",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios",
                column: "RolId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Usuarios_UsuarioId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Pagos_PagoId",
                table: "Proveedores");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoPagos_Pagos_PagoId",
                table: "TipoPagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Roles_RolId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_RolId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_TipoPagos_PagoId",
                table: "TipoPagos");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_PagoId",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_UsuarioId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "RolId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PagoId",
                table: "TipoPagos");

            migrationBuilder.DropColumn(
                name: "PagoId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Pagos");
        }
    }
}
