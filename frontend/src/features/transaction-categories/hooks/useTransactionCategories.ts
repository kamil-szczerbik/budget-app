import { useState, useEffect } from "react";
import type { TransactionCategory } from "../models/transaction-category";
import { getTransactionCategories } from "../transaction-categories.api";

export function useTransactionCategories() {
  const [data, setData] = useState<TransactionCategory[]>([]);

  useEffect(() => {
    getTransactionCategories().then(setData);
  }, []);

  return data;
}
