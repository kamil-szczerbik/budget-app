import { Outlet } from "react-router-dom";
import { Sidebar } from "./components/sidebar/Sidebar";

export default function AppLayout() {
  return (
    <>
      <div style={{ display: "flex", height: "100vh" }}>
        <Sidebar />

        <main style={{ flex: 1, padding: 16 }}>
          <Outlet />
        </main>
      </div>
    </>
  );
}
