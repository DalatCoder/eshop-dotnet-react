import React from "react";
import { Button, DatePicker, Space } from "antd";

export const Dashboard = () => {
  return (
    <div>
      <h1>Dashboard</h1>
      <Space>
        <DatePicker />
        <Button type="primary">Primary Button</Button>
      </Space>
    </div>
  );
};
