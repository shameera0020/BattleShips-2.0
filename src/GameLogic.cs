
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
static class GameLogic
{
	/// <summary>
	/// The entry point of the program, where the program control starts and ends.
	/// </summary>
	public static void Main()
	{
		//Opens a new Graphics Window
		SwinGame.OpenGraphicsWindow("Battle Ships", 800, 600);

		//Load Resources
		LoadResources();

		SwinGame.PlayMusic(GameMusic("Background"));

		//Game Loop
		do {
			HandleUserInput();
			DrawScreen();
		} while (!(SwinGame.WindowCloseRequested() == true | CurrentState == GameState.Quitting));

		SwinGame.StopMusic();

		//Free Resources and Close Audio, to end the program.
		FreeResources();
	}
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
