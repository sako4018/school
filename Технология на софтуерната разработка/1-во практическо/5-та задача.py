bgn = float(input("Enter amount in BGN: "))
changedval = str(input("Enter currency to change to (USD, EUR, GBP): "))
if changedval.upper() == "USD":
    usd = bgn / 1.815
    print(f"Amount in USD: {usd}")
elif changedval.upper() == "EUR":
    eur = bgn / 1.95583
    print(f"Amount in EUR: {eur}")
elif changedval.upper() == "GBP":
    gbp = bgn / 2.253
    print(f"Amount in GBP: {gbp}")