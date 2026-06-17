import { useState, useEffect } from "react";
import type { Currency } from "../models/currency";
import { getCurrencies } from "../currencies.api";

export function useCurrencies() {
  const [data, setData] = useState<Currency[]>([]);

  useEffect(() => {
    getCurrencies().then(setData);
  }, []);

  return data;
}
