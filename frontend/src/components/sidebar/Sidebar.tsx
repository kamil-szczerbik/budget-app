import type { NavItem } from "@/types/nav-item";
import { Coins, CreditCard, LayoutDashboard, Tags, Wallet } from "lucide-react";
import { NavLink } from "react-router-dom";

const items: NavItem[] = [
  { label: "Dashboard", icon: LayoutDashboard, to: "/" },
  { label: "Transactions", icon: CreditCard, to: "/transactions" },
  { label: "Wallets", icon: Wallet, to: "/wallets" },
  { label: "Categories", icon: Tags, to: "/categories" },
  { label: "Currencies", icon: Coins, to: "/currencies" },
];

export function Sidebar() {
  return (
    <aside className="h-screen w-64 border-r bg-background p-3 flex flex-col">
      <div className="mb-6 px-2 text-lg font-semibold">Budget App</div>

      <nav className="flex flex-col gap-1">
        {items.map((item) => (
          <NavLink
            key={item.to}
            to={item.to}
            className={({ isActive }) =>
              `flex items-center gap-3 rounded-md px-3 py-2 text-sm transition
                  ${isActive ? "bg-muted font-medium" : "hover:bg-muted/50"}`
            }
          >
            <item.icon size={18} />
            {item.label}
          </NavLink>
        ))}
      </nav>

      <div className="mt-auto text-xs text-muted-foreground px-2">v0.1</div>
    </aside>
  );
}
