﻿using Google.Cloud.Speech.V1Beta1;
using Google.Protobuf;
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using static Google.Cloud.Speech.V1Beta1.Speech;

namespace kynnaugh
{
	class SpeechTranscriber
	{
		public SpeechTranscriber()
		{
			Console.WriteLine("Creating transcriber");
		}

		public string TranscribeSpeech(byte[] speechData)
		{
			Console.WriteLine("Transcribing " + speechData.Length + " bytes of speechData");
			Task<ChannelCredentials> t = GoogleGrpcCredentials.GetApplicationDefaultAsync();
			t.Wait();
			Channel channel = new Channel("speech.googleapis.com", t.Result);
			SpeechClient client = new SpeechClient(channel);
			RecognitionConfig config = new RecognitionConfig
			{
				ProfanityFilter = false,
				Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
				SampleRate = 16000,
				LanguageCode = "en-US",
				MaxAlternatives = 1
			};
			RecognitionAudio audio = new RecognitionAudio
			{
				Content = ByteString.CopyFrom(speechData)
			};

			SyncRecognizeRequest req = new SyncRecognizeRequest
			{
				Audio = audio,
				Config = config
			};

			SyncRecognizeResponse resp = client.SyncRecognize(req);

			Console.WriteLine("Got " + resp.Results.Count + " transcription results");

			if (resp.Results.Count > 0)
			{
				SpeechRecognitionResult res = resp.Results.First();
				Console.WriteLine("Got " + res.Alternatives.Count + " alternatives in the first result");
				if (res.Alternatives.Count > 0)
				{
					SpeechRecognitionAlternative alt = res.Alternatives[0];
					Console.WriteLine("Got transcription \"" + alt + "\"");
					return alt.Transcript;
				}
			}

			Console.WriteLine("No valid transcription results");
			return null;
		}
	}
}
