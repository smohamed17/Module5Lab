using Module5Lab;

// creating a new player with a life 
// and adding the points to the player score
Player strong = new Player("Frankenstein", 1);
strong.AddPoints(100);
// displaying the score. 
Console.WriteLine("Welcome to the horror game! your score currently:  " + strong.GetScore() + " You have " 
+ strong.GetLivesLeft() + " lives left!! ");
// killing the player's character

strong.Kill();
Console.WriteLine("An orc attacks you. Sorry, you've been killed. You have " + strong.GetLivesLeft() + 
" lives left! ");

// creating the superplayer here.
SuperPlayer superPowers = new SuperPlayer();

//adding points to the SuperPlayer's account
superPowers.AddPoints(200);
superPowers.Fly(); // adding the ability to fly for the SuperPlayer.
Console.WriteLine($"SuperPlayer score: {superPowers.GetScore()}, Lives left: {superPowers.GetLivesLeft()}");