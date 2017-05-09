using ChessEngine.Engine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechRecognition;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ChessMaster
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const string SRGS_FILE = "grammar.xml";
        SpeechRecognizer recognizer;
        Engine engine;

        public MainPage()
        {
            this.InitializeComponent();
            engine = new Engine();
            engine.GameDifficulty = Engine.Difficulty.Easy;
            engine.NewGame();
            initializeSpeechRecognizer();
        }
        private async void initializeSpeechRecognizer()
        {
            // Initialize recognizer
            recognizer = new SpeechRecognizer();

            // Set event handlers
            recognizer.StateChanged += RecognizerStateChanged;
            recognizer.ContinuousRecognitionSession.ResultGenerated += RecognizerResultGenerated;

            // Load Grammer file constraint
            string fileName = String.Format(SRGS_FILE);
            StorageFile grammarContentFile = await Package.Current.InstalledLocation.GetFileAsync(fileName);

            SpeechRecognitionGrammarFileConstraint grammarConstraint = new SpeechRecognitionGrammarFileConstraint(grammarContentFile);

            // Add to grammer constraint
            recognizer.Constraints.Add(grammarConstraint);

            // Compile grammer
            SpeechRecognitionCompilationResult compilationResult = await recognizer.CompileConstraintsAsync();

            Debug.WriteLine("Status: " + compilationResult.Status.ToString());

            // If successful, display the recognition result.
            if (compilationResult.Status == SpeechRecognitionResultStatus.Success)
            {
                Debug.WriteLine("Result: " + compilationResult.ToString());

                await recognizer.ContinuousRecognitionSession.StartAsync();
            }
            else
            {
                Debug.WriteLine("Status: " + compilationResult.Status);
            }
        }
        // Recognizer generated results
        private void RecognizerResultGenerated(SpeechContinuousRecognitionSession session, SpeechContinuousRecognitionResultGeneratedEventArgs args)
        {
            // Output debug strings
            Debug.WriteLine(args.Result.Status);
            Debug.WriteLine(args.Result.Text);

            int count = args.Result.SemanticInterpretation.Properties.Count;

            Debug.WriteLine("Count: " + count);
            Debug.WriteLine("Tag: " + args.Result.Constraint.Tag);

            // Check for different tags and initialize the variables
            String PieceType = args.Result.SemanticInterpretation.Properties.ContainsKey("PieceType") ?
                            args.Result.SemanticInterpretation.Properties["PieceType"][0].ToString() :
                            "";

            String SourceRow = args.Result.SemanticInterpretation.Properties.ContainsKey("SourceRow") ?
                            args.Result.SemanticInterpretation.Properties["SourceRow"][0].ToString() :
                            "";

            String SourceColumn = args.Result.SemanticInterpretation.Properties.ContainsKey("SourceColumn") ?
                            args.Result.SemanticInterpretation.Properties["SourceColumn"][0].ToString() :
                            "";

            String DistinationRow = args.Result.SemanticInterpretation.Properties.ContainsKey("DistinationRow") ?
                          args.Result.SemanticInterpretation.Properties["DistinationRow"][0].ToString() :
                          "";

            String DistinationColumn = args.Result.SemanticInterpretation.Properties.ContainsKey("DistinationColumn") ?
                          args.Result.SemanticInterpretation.Properties["DistinationColumn"][0].ToString() :
                          "";

            Debug.WriteLine("PieceType: " + PieceType + "\n" +", SourceRow: " + SourceRow + ", SourceColumn: " + SourceColumn + " to " 
                + " DistinationRow: " + DistinationRow + " DistinationColumn: " + DistinationColumn);
            Debug.Write("Valid Move: ");

            /*var x = engine.MovePiece(
                Convert.ToByte(SourceColumn[0] - 'A'), 
                Convert.ToByte(SourceRow), 
                Convert.ToByte(DistinationColumn[0] - 'A'), 
                Convert.ToByte(DistinationRow));*/
            var y = engine.IsValidMove(48, 32);
            var x = engine.MovePiece(48, 32);
            engine.Undo();
            Debug.WriteLine("Source Position: " + engine.LastMove.MovingPiecePrimary.SrcPosition.ToString() + " Destination Position: " + engine.LastMove.MovingPiecePrimary.DstPosition.ToString());
            Debug.WriteLine(x.ToString() + y.ToString());
            engine.AiPonderMove(null);
        }

        // Recognizer state changed
        private void RecognizerStateChanged(SpeechRecognizer sender, SpeechRecognizerStateChangedEventArgs args)
        {
            Debug.WriteLine("Speech recognizer state: " + args.State.ToString());
        }

    }
}
