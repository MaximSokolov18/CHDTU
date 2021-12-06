from tkinter import *

def b1(event):
    if (realAction["text"] == "" and resultAction["text"] != ""):
        resultAction["text"] = ""
    realAction["text"] += event.widget['text']
def removeNum(event):
    realAction["text"] = realAction["text"][:-1]
def clickAction(event):
    numReal = 0
    numResult = 0
    strRealAction = realAction["text"]
    strResultAction = resultAction["text"]
    if strResultAction == "":
        resultAction["text"] = strRealAction
        realAction["text"] = event.widget["text"]
    else:
        numResult = float(strResultAction)
        if strRealAction[0] == "*":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult * numReal
            resultAction["text"] = result
        elif strRealAction[0] == "/":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult / numReal
            resultAction["text"] = result
        elif strRealAction[0] == "+":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult + numReal
            resultAction["text"] = result
        elif strRealAction[0] == "-":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult - numReal
            resultAction["text"] = result
        elif strRealAction[0] == "^":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult ** numReal
            resultAction["text"] = result
        realAction["text"] = event.widget["text"]

def clickKeyMin(event):
    numReal = 0
    numResult = 0
    strRealAction = realAction["text"]
    strResultAction = resultAction["text"]
    if (strRealAction == "+" or strRealAction == "-" or strRealAction == "*" or strRealAction == "/" or strRealAction == "^"):
        realAction["text"] += "-"
        return

    if strResultAction == "":
        resultAction["text"] = strRealAction
        realAction["text"] = event.widget["text"]
    else:
        numResult = float(strResultAction)
        if strRealAction[0] == "*":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult * numReal
            resultAction["text"] = result
        elif strRealAction[0] == "/":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult / numReal
            resultAction["text"] = result
        elif strRealAction[0] == "+":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult + numReal
            resultAction["text"] = result
        elif strRealAction[0] == "-":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult - numReal
            resultAction["text"] = result
        elif strRealAction[0] == "^":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult ** numReal
            resultAction["text"] = result
        realAction["text"] = event.widget["text"]

def resultShow(event):
    numReal = 0
    numResult = 0
    strRealAction = realAction["text"]
    strResultAction = resultAction["text"]
    if strResultAction == "":
        resultAction["text"] = strRealAction
        realAction["text"] = event.widget["text"]
    else:
        numResult = float(strResultAction)
        if strRealAction[0] == "*":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult * numReal
            resultAction["text"] = result
        elif strRealAction[0] == "/":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult / numReal
            resultAction["text"] = result
        elif strRealAction[0] == "+":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult + numReal
            resultAction["text"] = result
        elif strRealAction[0] == "-":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult - numReal
            resultAction["text"] = result
        elif strRealAction[0] == "^":
            strRealAction = strRealAction[1:]
            numReal = float(strRealAction)
            result = numResult ** numReal
            resultAction["text"] = result
    realAction["text"] = ""

def addPoiner(event):
    strRealAction = realAction["text"]
    if (len(strRealAction) == 10 or strRealAction == ""):
        return
    realAction["text"] += event.widget["text"]

root = Tk()
root.geometry("255x295")
resultAction = Label(text="", font="Arial 12", bg="#fff", fg="#000", width=26)
resultAction.grid(row=0, column=0, columnspan=4)
realAction = Label(text="", font="Arial 14", bg="#fff", fg="#000", width=23)
realAction.grid(row=1, column=0, columnspan=4)
keyBackspace = Button(text="Backspace", font="Arial 14")
keyBackspace.bind("<Button-1>", removeNum)
keyBackspace.grid(row=2, column=0, ipadx=8, ipady=5, columnspan=2)
keyEquals = Button(text="=", font="Arial 14", width=4)
keyEquals.bind("<Button-1>", resultShow)
keyEquals.grid(row=2, column=2,ipadx=5, ipady=5)
keyMinus = Button(text="-", font="Arial 14", width=4)
keyMinus.bind("<Button-1>", clickKeyMin)
keyMinus.grid(row=2, column=3,ipadx=5, ipady=5)
keyPlus = Button(text="+", font="Arial 14", width=4)
keyPlus.bind("<Button-1>", clickAction)
keyPlus.grid(row=3, column=3,ipadx=5, ipady=5)
keyDivision = Button(text="/", font="Arial 14", width=4)
keyDivision.bind("<Button-1>", clickAction)
keyDivision.grid(row=4, column=3,ipadx=5, ipady=5)
keyMultiplication = Button(text="*", font="Arial 14", width=4)
keyMultiplication.bind("<Button-1>", clickAction)
keyMultiplication.grid(row=5, column=3,ipadx=5, ipady=5)
keySeven = Button(text="7", font="Arial 14", width=4)
keySeven.bind("<Button-1>", b1)
keySeven.grid(row=3, column=0,ipadx=5, ipady=5)
keyEight = Button(text="8", font="Arial 14", width=4)
keyEight.bind("<Button-1>", b1)
keyEight.grid(row=3, column=1,ipadx=5, ipady=5)
keyNine = Button(text="9", font="Arial 14", width=4)
keyNine.bind("<Button-1>", b1)
keyNine.grid(row=3, column=2,ipadx=5, ipady=5)
keyFour = Button(text="4", font="Arial 14", width=4)
keyFour.bind("<Button-1>", b1)
keyFour.grid(row=4, column=0,ipadx=5, ipady=5)
keyFife = Button(text="5", font="Arial 14", width=4)
keyFife.bind("<Button-1>", b1)
keyFife.grid(row=4, column=1,ipadx=5, ipady=5)
keySix = Button(text="6", font="Arial 14", width=4)
keySix.bind("<Button-1>", b1)
keySix.grid(row=4, column=2,ipadx=5, ipady=5)
keyOne = Button(text="1", font="Arial 14", width=4)
keyOne.bind("<Button-1>", b1)
keyOne.grid(row=5, column=0,ipadx=5, ipady=5)
keyTwo = Button(text="2", font="Arial 14", width=4)
keyTwo.bind("<Button-1>", b1)
keyTwo.grid(row=5, column=1,ipadx=5, ipady=5)
keyThree = Button(text="3", font="Arial 14", width=4)
keyThree.bind("<Button-1>", b1)
keyThree.grid(row=5, column=2,ipadx=5, ipady=5)
keyZero = Button(text="0", font="Arial 14")
keyZero.bind("<Button-1>", b1)
keyZero.grid(row=6, column=0,ipadx=50, ipady=5, columnspan=2)
keyPoint = Button(text=".", font="Arial 14")
keyPoint.bind("<Button-1>", addPoiner)
keyPoint.grid(row=6, column=2,ipadx=20, ipady=5)
keyPow = Button(text="^", font="Arial 14")
keyPow.bind("<Button-1>", clickAction)
keyPow.grid(row=6, column=3,ipadx=20, ipady=5)

root.mainloop()