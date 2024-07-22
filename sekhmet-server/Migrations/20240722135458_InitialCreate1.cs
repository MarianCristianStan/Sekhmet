using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sekhmet_server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conversations",
                columns: table => new
                {
                    Conversation_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conversation_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conversation_Type = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversations", x => x.Conversation_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password_Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Profile_Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Message_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_ID_Sender = table.Column<int>(type: "int", nullable: false),
                    User_ID_Receiver = table.Column<int>(type: "int", nullable: false),
                    Conversation_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Message_ID);
                    table.ForeignKey(
                        name: "FK_Messages_Conversations_Conversation_ID",
                        column: x => x.Conversation_ID,
                        principalTable: "Conversations",
                        principalColumn: "Conversation_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conversation_Users",
                columns: table => new
                {
                    Conversation_User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conversation_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversation_Users", x => x.Conversation_User_ID);
                    table.ForeignKey(
                        name: "FK_Conversation_Users_Conversations_Conversation_ID",
                        column: x => x.Conversation_ID,
                        principalTable: "Conversations",
                        principalColumn: "Conversation_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Conversation_Users_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Follows",
                columns: table => new
                {
                    FollowingUserId = table.Column<int>(type: "int", nullable: false),
                    FollowedUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Follows", x => new { x.FollowingUserId, x.FollowedUserId });
                    table.ForeignKey(
                        name: "FK_Follows_Users_FollowedUserId",
                        column: x => x.FollowedUserId,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Follows_Users_FollowingUserId",
                        column: x => x.FollowingUserId,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Post_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_At_Datetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    User_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Post_ID);
                    table.ForeignKey(
                        name: "FK_Posts_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comms",
                columns: table => new
                {
                    Comm_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_At_Datetime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created_By_User_ID = table.Column<int>(type: "int", nullable: false),
                    Post_ID = table.Column<int>(type: "int", nullable: false),
                    Comm_Reply_To_ID = table.Column<int>(type: "int", nullable: true),
                    Comm_Replied_ToComm_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comms", x => x.Comm_ID);
                    table.ForeignKey(
                        name: "FK_Comms_Comms_Comm_Replied_ToComm_ID",
                        column: x => x.Comm_Replied_ToComm_ID,
                        principalTable: "Comms",
                        principalColumn: "Comm_ID");
                    table.ForeignKey(
                        name: "FK_Comms_Posts_Post_ID",
                        column: x => x.Post_ID,
                        principalTable: "Posts",
                        principalColumn: "Post_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comms_Users_Created_By_User_ID",
                        column: x => x.Created_By_User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Like_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Post_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Like_ID);
                    table.ForeignKey(
                        name: "FK_Likes_Posts_Post_ID",
                        column: x => x.Post_ID,
                        principalTable: "Posts",
                        principalColumn: "Post_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likes_Users_User_ID",
                        column: x => x.User_ID,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post_Medias",
                columns: table => new
                {
                    Post_Media_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Media_File = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Post_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post_Medias", x => x.Post_Media_ID);
                    table.ForeignKey(
                        name: "FK_Post_Medias_Posts_Post_ID",
                        column: x => x.Post_ID,
                        principalTable: "Posts",
                        principalColumn: "Post_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comms_Comm_Replied_ToComm_ID",
                table: "Comms",
                column: "Comm_Replied_ToComm_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Comms_Created_By_User_ID",
                table: "Comms",
                column: "Created_By_User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Comms_Post_ID",
                table: "Comms",
                column: "Post_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_Users_Conversation_ID",
                table: "Conversation_Users",
                column: "Conversation_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Conversation_Users_User_ID",
                table: "Conversation_Users",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Follows_FollowedUserId",
                table: "Follows",
                column: "FollowedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_Post_ID",
                table: "Likes",
                column: "Post_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_User_ID",
                table: "Likes",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Conversation_ID",
                table: "Messages",
                column: "Conversation_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_Medias_Post_ID",
                table: "Post_Medias",
                column: "Post_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_User_ID",
                table: "Posts",
                column: "User_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comms");

            migrationBuilder.DropTable(
                name: "Conversation_Users");

            migrationBuilder.DropTable(
                name: "Follows");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Post_Medias");

            migrationBuilder.DropTable(
                name: "Conversations");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
