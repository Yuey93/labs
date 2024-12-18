class BankAccount:
    def __init__(self,name,balance,accountNum=100000) -> None:
        self.name = name
        self.accountNum = accountNum
        self.balance = balance
    def deposit(self,num):
        self.balance+=num
        print("Current balance after deposit:", self.balance)
    def withdraw(self,num):
        if self.balance-num < 0:
            print("Cannot withdraw more than is held")
        else:
            self.balance-=num
            print("Current balance after withdraw:", self.balance)
    def getAccNumber(self):
        print("Account number is",self.accountNum)
    
class CurrentAccount(BankAccount):
    def __init__(self, name, balance, overdraftLimit, accountNum=100000) -> None:
        super().__init__(name, balance, accountNum)
        self.overdraftLimit = overdraftLimit
    def withdraw(self, num):
        if self.balance - num < self.overdraftLimit:
            print("Cannot go below overdraft limit")
        else:
            self.balance-=num
            print("Current balance after withdraw:", self.balance)
        
class SavingsAccount(BankAccount):
    def __init__(self, name, balance, interestRate, accountNum=100000) -> None:
        super().__init__(name, balance, accountNum)
        self.interestRate = interestRate
    def AddInterest(self):
        self.balance *= self.interestRate
        print("Current balance after added interest:", self.balance)


acc1 = CurrentAccount("test",300,-500)

acc1.deposit(200)
acc1.withdraw(600)
acc1.withdraw(600)
acc1.getAccNumber()

acc2 = SavingsAccount("test",100,1.03,10023)

acc2.deposit(300)
acc2.withdraw(300)
acc2.AddInterest()
acc2.AddInterest()
acc2.getAccNumber()



