import speech_recognition as sr
from playsound import playsound
from gtts import gTTS
import random

def record(ask=False):
        r = sr.Recognizer()
        
        with sr.Microphone() as source:
            if ask:
                print(ask)
            audio = r.listen(source)
            voice = ""
            try:
                voice =r.recognize_google(audio, language="tr-TR")
            except sr.UnknownValueError:
                print("asistan : anlayamadım")
            except sr.RequestError:
                print("sistem çalışmıyor")
            return voice
        
voice = record()
if voice != '':
    print(voice)