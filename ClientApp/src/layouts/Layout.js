import "./layout.css";
import {
  LaptopOutlined,
  NotificationOutlined,
  UserOutlined,
  PieChartOutlined,
  AccountBookOutlined,
} from "@ant-design/icons";
import { Layout, Menu } from "antd";
import React, { useState } from "react";

import { useNavigate } from "react-router-dom";

const { Header, Content, Sider, Footer } = Layout;

function getItem(label, key, icon, children) {
  return {
    key,
    icon,
    children,
    label,
  };
}

const primaryMenus = [
  getItem("Tổng quan", "1"),
  getItem("Sản phẩm", "2"),
  getItem("Đơn hàng", "3"),
];

const sideMenus = [
  getItem("Tổng quan", "1", <PieChartOutlined />),
  getItem("Sản phẩm", "2", <LaptopOutlined />, [
    getItem("Tất cả", "2-1"),
    getItem("Thêm mới", "2-2"),
    getItem("Thể loại", "2-3"),
  ]),
  getItem("Đơn hàng", "3", <NotificationOutlined />),
  getItem("Người dùng", "4", <UserOutlined />),
  getItem("Giới thiệu", "5", <AccountBookOutlined />),
];

const mapPrimaryMenu = {
  1: "/",
  2: "/admin/products",
  3: "/admin/orders",
};

const mapLinkSideMenu = {
  1: "/",
  2: "/admin/products",
  "2-1": "/admin/products",
  "2-2": "/admin/products/create",
  "2-3": "/admin/categories",
  3: "/admin/orders",
  4: "/admin/users",
  5: "/admin/about",
};

const AdminLayout = (props) => {
  const [collapsed, setCollapsed] = useState(false);
  const navigate = useNavigate();

  const handleOnPrimaryMenuItemSelected = ({
    item,
    key,
    keyPath,
    selectedKeys,
    domEvent,
  }) => {
    const link = mapPrimaryMenu[key] || null;

    if (link) {
      navigate(link);
    } else {
      alert("404");
    }
  };

  const handleOnSiderMenuItemSelected = ({
    item,
    key,
    keyPath,
    selectedKeys,
    domEvent,
  }) => {
    const link = mapLinkSideMenu[key] || null;

    if (link) {
      navigate(link);
    } else {
      alert("404");
    }
  };

  return (
    <Layout style={{ minHeight: "100vh" }}>
      <Header className="header">
        <div className="logo" />
        <Menu
          onSelect={handleOnPrimaryMenuItemSelected}
          theme="dark"
          mode="horizontal"
          items={primaryMenus}
        />
      </Header>
      <Layout>
        <Sider
          collapsible
          collapsed={collapsed}
          onCollapse={(value) => setCollapsed(value)}
          width={200}
          className="site-layout-background"
        >
          <Menu
            mode="inline"
            theme="dark"
            defaultSelectedKeys={["1"]}
            style={{
              height: "100%",
              borderRight: 0,
            }}
            items={sideMenus}
            onSelect={handleOnSiderMenuItemSelected}
          />
        </Sider>
        <Layout
          style={{
            padding: "0 24px 24px",
          }}
        >
          <Content
            className="site-layout-background"
            style={{
              padding: 24,
              margin: 0,
            }}
          >
            {props.children}
          </Content>

          <Footer style={{ textAlign: "center" }}>
            EShopper Admin ©2022 - Created by NTH
          </Footer>
        </Layout>
      </Layout>
    </Layout>
  );
};

export default AdminLayout;
