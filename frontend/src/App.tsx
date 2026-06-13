import { useEffect, useState } from "react";
import type { Transaction } from "./features/transactions/models/transaction";
import { getTransactions } from "./features/transactions/api/transactions.api";

function App() {
  const [transactions, setTransactions] = useState<Transaction[]>([]);

  useEffect(() => {
    getTransactions().then(setTransactions);
  }, []);

  return (
    <>
      <h1>Transactions</h1>

      {transactions.map(t => (
        <div key={t.id}>
          {t.description ?? "brak opisu"} - {t.amount}
        </div>
      ))}
    </>
  )
}

export default App
