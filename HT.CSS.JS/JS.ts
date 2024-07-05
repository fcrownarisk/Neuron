function calculate(num1: number, num2: number, operator: any) {
    switch (operator) {
        case '+':
            return num1 + num2;
        case '-':
            return num1 - num2;
        case '*':
            return num1 * num2;
        case '/':
            if (num2 !== 0) {
               return num1 / num2;
            } else {
               alert("Division by zero is not allowed.");
               return null;
            }
        default:
            alert("Invalid operator.");
            return null;
    }
}