import { useState, useEffect } from "react";
import type { Wallet } from "../models/wallet";
import { getWallets } from "../wallets.api";

export function useWallets() {
  const [data, setData] = useState<Wallet[]>([]);

  useEffect(() => {
    getWallets().then(setData);
  }, []);

  return data;
}
