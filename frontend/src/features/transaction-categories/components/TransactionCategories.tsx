import { useTransactionCategories } from "../hooks/useTransactionCategories";

export default function TransactionCategories() {
  const transactionCategories = useTransactionCategories();

  return (
    <>
      <h1>Transactions</h1>

      {transactionCategories.map((category) => (
        <div key={category.id}>{category.name}</div>
      ))}
    </>
  );
}
