using System;

public class Quiz {
	protected string answer;
	protected string[] answerKey;
	protected string[] choice;
	protected bool remark;
	protected int score = 0;
	protected string[] question;

	public string[] AnswerKey {
		get { return answerKey; }
		set { answerKey = value; }
	}

	public string[] Choice {
		get { return choice; }
		set { choice = value; }
	}

	public string[] Question {
		get { return question; }
		set { question = value; }
	}

	public Quiz(string[] question, string[] choice, string[] answerKey) {
		this.Question = question;
		this.Choice = choice;
		this.AnswerKey = answerKey;
	}

	~ Quiz() {
		Console.WriteLine("\nCleaning up spaces...");

		if(true) {
			Console.Beep();
			Console.WriteLine("Success!");
		}
	}

	public void StartQuiz() {
		for(int r=0; r < Question.Length; r++) {
			Console.WriteLine("\n" + (r+1) + ". " + Question[r]);
			Console.WriteLine(Choice[r]);
			Console.Write("\nEnter your answer: ");
			answer = Console.ReadLine();
			this.remark = answer == answerKey[r];
			
			if(remark == true) {
				score += 1;
				Console.WriteLine("Correct!");
			} else {
				Console.WriteLine("Wrong! the answer is " + answerKey[r]);
			}
		}
	}

	public void GetScore() {

		Console.WriteLine("\n\nScore: " + score + "/" + question.Length);
	}
}

public class Yerenzter {
	public static void Main(String[] args) {
		string[] question = {
			"Where is Antique was located?",
			"What is the capital of Antique?",
			"What language is spoken in Antique?"
		};
		string[] choice = {
			"\nA. Visayas \nB. Luzon \nC. Mindanao",
			"\nA. Masbate City \nB. San Jose \nC. Kalibo",
			"\nA. Kinaray-A \nB. Hiligaynon \nC. Tagalog"
		};
		string[] answerKey = {"A", "B", "A"};
		Quiz q = new Quiz(question, choice, answerKey);

		q.StartQuiz();
		q.GetScore();

		Console.WriteLine("\n\nPress <ENTER> to finish program.");
		Console.ReadKey();
	}
}
