import speech_recognition as sr
import pyttsx3 

r = sr.Recognizer()
with sr.Microphone(device_index = 1) as source:
    print("скажите")
    audio = r.listen(source)
    u = pyttsx3.init() 
    u.say("lol") 
    u.runAndWait()

query = r.recognize_google(audio, language = "ru-RU")
print("вы сказали: " + query.lower())

en = pyttsx3.init() 
en.say(query.lower()) 
en.runAndWait()