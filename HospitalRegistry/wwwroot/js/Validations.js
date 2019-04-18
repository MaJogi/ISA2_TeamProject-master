function IsFieldEmpty() {
    if ((document.getElementById("TxtFName").value == "")
        || (document.getElementById("TxtLName").value == "")
        || (document.getElementById("TxtIdCode").value == "")) {
        return "Required field!";
    }
    return "";
}

function ContainsOnlyLetters() {
    var letters = /^[a-zA-Z]+$/;
    if ((document.getElementById("TxtFName").value.match(letters))
        && (document.getElementById("TxtLName").value.match(letters))) {
        return "";
    }
    return "Use only *ENG* letters!";
}

function ContainsOnlyNumbers() {
    var numbers = /^\d+$/;
    if ((document.getElementById("TxtIdCode").value.match(numbers))) {
        return "";
    }
    return "Use only numbers!";
}


function LengthIsValid() {
    if ((document.getElementById("TxtFName").value.length > 20)
        || (document.getElementById("TxtLName").value.length > 20)) {
        return "Length should be less than 20 characters";
    }
    return "";

}

var IdCodeLenght = 11;

function IsIdCodeInValid() {
    if (document.getElementById("TxtIdCode").value.length != IdCodeLenght)
       {
        return "Wrong length. ID Code contains 11 numbers!";
    }
    return ""; 
}

function IsValid() {
    var FieldEmptyMessage = IsFieldEmpty();
    var OnlyLettersMessage = ContainsOnlyLetters();
    var OnlyNumbersMessage = ContainsOnlyNumbers();
    var LengthIsValidMessage = LengthIsValid();
    var IsIdCodeInValidMessage = IsIdCodeInValid();
    var FinalErrorMessage = "Errors:";

    if (FieldEmptyMessage != "")
        FinalErrorMessage += "\n" + FieldEmptyMessage;
    if (OnlyLettersMessage != "")
        FinalErrorMessage += "\n" + OnlyLettersMessage;
    if (OnlyNumbersMessage != "")
        FinalErrorMessage += "\n" + OnlyNumbersMessage;
    if (LengthIsValidMessage != "")
        FinalErrorMessage += "\n" + LengthIsValidMessage;
    if (IsIdCodeInValidMessage != "")
        FinalErrorMessage += "\n" + IsIdCodeInValidMessage;
    if (FinalErrorMessage != "Errors:") {
        alert(FinalErrorMessage);
        return false;
    } else {
        return true;
    }

}