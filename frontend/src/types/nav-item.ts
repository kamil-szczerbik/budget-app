export type NavItem = {
  label: string;
  icon: React.ComponentType<{ size?: number }>;
  to: string;
};