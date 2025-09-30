using System;
/*

*/
namespace Calculator
{
	class Visual
	{
		static void Main(string [] args)
		{
			Console.WriteLine("Rock Paper Scissor Game /nWrite rock, paper or scissor:");
			Console.WriteLine("Rock Paper Scissors game. \nDo you want to play with a friend or with a bot? ");
			Console.WriteLine("Bot: 1 \nFriend: 2");
			int choose = int.Parse(Console.ReadLine());


			bool isPlaying = true;
			string continueToPlay = " ";


			while(isPlaying) {
				if(choose == 1) {  

					Program.playWithBot();

					Program.getAnsw();
					Console.WriteLine("Do you want play again, Yes or No?");	
					continueToPlay = Console.ReadLine();		

				} else if(choose == 2) {

					Program.playWithFriend();
					Program.getAnsw();
					Console.WriteLine("Do you want play again, Yes or No?");	
					continueToPlay = Console.ReadLine();

				} else {

					Console.WriteLine("Invalid choose!");
					Console.WriteLine("Rock Paper Scissors game. \nDo you want to play with a friend or with a bot? ");
					Console.WriteLine(" Bot: 1 \nFriend: 2");
					choose = int.Parse(Console.ReadLine());
				}

				continueToPlay = Console.ReadLine();


				if (continueToPlay == "no" || continueToPlay == "n" || continueToPlay == "No") {
					isPlaying = false;

				} else {
					Console.WriteLine("Bot: 1 \nFriend: 2");
					choose = int.Parse(Console.ReadLine());				    
				}
			}



			Console.ReadKey();
		}
	}

	class Game {

		public static string mode = " ";
		public static string playerResp = " ";
		public static string botResp = " ";
		public static string player1Resp = " ";
		public static string player2Resp = " ";


		public static void playWithBot()
		{

			mode = "PlayWithBotMode";
			Console.WriteLine("Player's turn, Rock, Paper or Scissors?  ");
			playerResp = Console.ReadLine();

			Random random = new Random();

			string [] botGuess = {"rock" , "paper" , "scissor"};

			int botIndx = random.Next(0, 3);
			botResp = botGuess[botIndx];

		}

		public static void playWithFriend()
		{

			mode = "PlayWithFriendMode";
			Console.WriteLine("Player1's turn, Rock, Paper or Scissor?");
			player1Resp = Console.ReadLine();
			Console.Clear();

			Console.WriteLine("Player2's turn, Rock, Paper or Scissor?");
			player2Resp = Console.ReadLine();

		}

		public static void getAnsw()
		{
			if(mode == "PlayWithBotMode")
			{
				if(botResp == playerResp)
				{
					Console.WriteLine($"Bot:{botResp} \nYou: {playerResp} \nIt is a draw.");
				}

				else if(botResp == "rock" && playerResp == "scissor" || 
						botResp == "paper" && playerResp == "rock"   ||
						botResp == "scissor" && playerResp == "paper")
				{
					Console.WriteLine($"Bot:{botResp} \nYou: {playerResp} \nBot/Computer won. You lost.");		
				}

				else
				{
					Console.WriteLine($"Bot:{botResp} \nYou: {playerResp} \nYou won. Bot/Computer lost.");
				}
			}

			else
			{
				if(player1Resp == player2Resp)
				{
					Console.WriteLine($"Player1:{player1Resp} \n layer2: {player2Resp} \nIt is a draw.");
				}

				else if(player1Resp == "rock" && player2Resp == "scissor" || 
						player1Resp == "paper" && player2Resp == "rock"   ||
						player1Resp == "scissor" && player2Resp == "paper")
				{
					Console.WriteLine($"Player1:{player1Resp}\n Player2: {player2Resp} player1 won. player2 lost.");		
				}

				else
				{
					Console.WriteLine($"Player1:{player1Resp} \nPlayer2: {player2Resp} \nPlayer2 won. Player1 lost.");
				}


			}
		}
	}	
}

