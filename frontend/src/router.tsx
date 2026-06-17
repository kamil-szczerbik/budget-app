import { createBrowserRouter } from "react-router-dom";
import TransactionCategories from "@/features/transaction-categories/components/TransactionCategories";
import AppLayout from "./AppLayout";
import Currencies from "./features/currencies/components/Currencies";
import Wallets from "./features/wallets/components/Wallets";

export const router = createBrowserRouter([
  {
    path: "/",
    element: <AppLayout />,
    children: [
      {
        path: "/transactions",
        element: <></>,
      },
      {
        path: "/wallets",
        element: <Wallets />,
      },
      {
        path: "/categories",
        element: <TransactionCategories />,
      },
      {
        path: "/currencies",
        element: <Currencies />,
      },
    ],
  },
]);
