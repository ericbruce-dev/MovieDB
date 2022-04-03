using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieDB.Data.Migrations
{
    public partial class ChangedNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movie",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Movie",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Poster",
                table: "Movie",
                newName: "poster");

            migrationBuilder.RenameColumn(
                name: "Overview",
                table: "Movie",
                newName: "overview");

            migrationBuilder.RenameColumn(
                name: "Backdrop",
                table: "Movie",
                newName: "backdrop");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movie",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "VoteAverage",
                table: "Movie",
                newName: "vote_average");

            migrationBuilder.RenameColumn(
                name: "TrailerUrl",
                table: "Movie",
                newName: "trailer_url");

            migrationBuilder.RenameColumn(
                name: "TagLine",
                table: "Movie",
                newName: "tag_line");

            migrationBuilder.RenameColumn(
                name: "RunTime",
                table: "Movie",
                newName: "run_time");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Movie",
                newName: "release_date");

            migrationBuilder.RenameColumn(
                name: "PosterType",
                table: "Movie",
                newName: "poster_type");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movie",
                newName: "movie_id");

            migrationBuilder.RenameColumn(
                name: "BackdropType",
                table: "Movie",
                newName: "backdrop_type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Movie",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Movie",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "poster",
                table: "Movie",
                newName: "Poster");

            migrationBuilder.RenameColumn(
                name: "overview",
                table: "Movie",
                newName: "Overview");

            migrationBuilder.RenameColumn(
                name: "backdrop",
                table: "Movie",
                newName: "Backdrop");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Movie",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "vote_average",
                table: "Movie",
                newName: "VoteAverage");

            migrationBuilder.RenameColumn(
                name: "trailer_url",
                table: "Movie",
                newName: "TrailerUrl");

            migrationBuilder.RenameColumn(
                name: "tag_line",
                table: "Movie",
                newName: "TagLine");

            migrationBuilder.RenameColumn(
                name: "run_time",
                table: "Movie",
                newName: "RunTime");

            migrationBuilder.RenameColumn(
                name: "release_date",
                table: "Movie",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "poster_type",
                table: "Movie",
                newName: "PosterType");

            migrationBuilder.RenameColumn(
                name: "movie_id",
                table: "Movie",
                newName: "MovieId");

            migrationBuilder.RenameColumn(
                name: "backdrop_type",
                table: "Movie",
                newName: "BackdropType");
        }
    }
}
