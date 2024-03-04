using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstname = table.Column<string>(name: "first_name", type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "nvarchar(max)", nullable: false),
                    totalcopies = table.Column<int>(name: "total_copies", type: "int", nullable: false),
                    copiesinuse = table.Column<int>(name: "copies_in_use", type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isbn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.id);
                });

            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('Pride and Prejudice', 'Jane', 'Austen', 100, 80, 'Hardcover', '1234567891', 'Fiction');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('To Kill a Mockingbird', 'Harper', 'Lee', 75, 65, 'Paperback', '1234567892', 'Fiction');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Catcher in the Rye', 'J.D.', 'Salinger', 50, 45, 'Hardcover', '1234567893', 'Fiction');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Great Gatsby', 'F. Scott', 'Fitzgerald', 50, 22, 'Hardcover', '1234567894', 'Non-Fiction');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Alchemist', 'Paulo', 'Coelho', 50, 35, 'Hardcover', '1234567895', 'Biography');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Book Thief', 'Markus', 'Zusak', 75, 11, 'Hardcover', '1234567896', 'Mystery');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Chronicles of Narnia', 'C.S.', 'Lewis', 100, 14, 'Paperback', '1234567897', 'Sci-Fi');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Da Vinci Code', 'Dan', 'Brown', 50, 40, 'Paperback', '1234567898', 'Sci-Fi');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Grapes of Wrath', 'John', 'Steinbeck', 50, 35, 'Hardcover', '1234567899', 'Fiction');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Hitchhiker''s Guide to the Galaxy', 'Douglas', 'Adams', 50, 35, 'Paperback', '1234567900', 'Non-Fiction');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('Moby-Dick', 'Herman', 'Melville', 30, 8, 'Hardcover', '8901234567', 'Fiction');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('To Kill a Mockingbird', 'Harper', 'Lee', 20, 0, 'Paperback', '9012345678', 'Non-Fiction');");


            migrationBuilder.Sql(@"INSERT INTO books (title, first_name, last_name, total_copies, copies_in_use, type, isbn, category)
VALUES ('The Catcher in the Rye', 'J.D.', 'Salinger', 10, 1, 'Hardcover', '0123456789', 'Non-Fiction');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
