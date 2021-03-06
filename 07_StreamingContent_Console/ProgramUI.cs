using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Exisitng Content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                    case "banana": //just showing you can type anything here
                        //create new content
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        //ViewAllConetent
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        //View content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        //Update existing content
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        //deleate existing content
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewContent() //optional challenge - ask the user to confirm information before adding to directory
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content.");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            // newContent.StarRating = Convert.ToDouble(Console.ReadLine());   - same as star rating conversion above

            //GenreType
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //MaturityRating
            Console.WriteLine("Enter the maturity rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            //string ratingAsSting = Console.ReadLine();
            //int ratingAsInt = Convert.ToInt32(ratingAsSting);
            //newContent.MaturityRating = (MaturityRating)ratingAsInt;

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly!!!");
            }
            else
            {
                Console.WriteLine("Could not add the content.");
            }
        }
        private void DisplayAllContent() //Display all content in the directory
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent)
            {
                Console.ForegroundColor = (ConsoleColor.Green);
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() //get title from the user then display all properties of content that has that title
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the name of the title you would like to search: ");
            StreamingContent selectedContent = _repo.GetContentByTitle(Console.ReadLine());


            if (selectedContent != null)
            {
                Console.WriteLine($"Title: { selectedContent.Title}\n" +
                        $"Description: {selectedContent.Description}\n" +
                        $"Star Rating: {selectedContent.StarRating}\n" +
                        $"Genre: {selectedContent.TypeOfGenre}\n" +
                        $"Rating: {selectedContent.MaturityRating}\n" +
                        $"Is Family Friendly: {selectedContent.IsFamilyFriendly}");
            }
            else
            {
                Console.WriteLine("There is no content by that title");
            }
        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you would like to update");

            string oldTitle = Console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the new title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the new description of the content.");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the new star rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            // newContent.StarRating = Convert.ToDouble(Console.ReadLine());   - same as star rating conversion above

            //GenreType
            Console.WriteLine("Enter the new genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //MaturityRating
            Console.WriteLine("Enter the new maturity rating number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfully");
            }
            else
            {
                Console.WriteLine("No content by that title exists");
            }
        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title for the content you want to delete.");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());

            if (wasDeleted)
            {
                Console.WriteLine("Youre content was successfully deleted!");
            }
            else
            {
                Console.WriteLine("Content could not be deleted.");
            }

        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets accidentlly transported back in time", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Laser Swords", 4.8, GenreType.SciFi, MaturityRating.PG);
            StreamingContent rubber = new StreamingContent("Rubber", "A car tire comes to life and kills", 1.2, GenreType.Horror, MaturityRating.R);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);
        }
    }
}
