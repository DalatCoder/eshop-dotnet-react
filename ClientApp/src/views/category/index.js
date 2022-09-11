import React, { useState } from "react";
import { Col, Row, Form, Input, InputNumber, Button, Checkbox } from "antd";
import { Space, Table, Tag } from "antd";
import urlSlug from "url-slug";

const CategoryView = () => {
  const [form] = Form.useForm();

  const [aliasTitle, setAliasTitle] = useState("");

  const columns = [
    {
      title: "Name",
      dataIndex: "name",
      key: "name",
      render: (text) => <a>{text}</a>,
    },
    {
      title: "Age",
      dataIndex: "age",
      key: "age",
    },
    {
      title: "Address",
      dataIndex: "address",
      key: "address",
    },
    {
      title: "Tags",
      key: "tags",
      dataIndex: "tags",
      render: (_, { tags }) => (
        <>
          {tags.map((tag) => {
            let color = tag.length > 5 ? "geekblue" : "green";

            if (tag === "loser") {
              color = "volcano";
            }

            return (
              <Tag color={color} key={tag}>
                {tag.toUpperCase()}
              </Tag>
            );
          })}
        </>
      ),
    },
    {
      title: "Action",
      key: "action",
      render: (_, record) => (
        <Space size="middle">
          <a>Invite {record.name}</a>
          <a>Delete</a>
        </Space>
      ),
    },
  ];
  const data = [
    {
      key: "1",
      name: "John Brown",
      age: 32,
      address: "New York No. 1 Lake Park",
      tags: ["nice", "developer"],
    },
    {
      key: "2",
      name: "Jim Green",
      age: 42,
      address: "London No. 1 Lake Park",
      tags: ["loser"],
    },
    {
      key: "3",
      name: "Joe Black",
      age: 32,
      address: "Sidney No. 1 Lake Park",
      tags: ["cool", "teacher"],
    },
  ];

  const onFinish = (values) => {
    console.log("Success:", values);
  };

  const onFinishFailed = (errorInfo) => {
    console.log("Failed:", errorInfo);
  };

  const onTitleBlur = (e) => {
    const title = e.target.value || "";
    const slug = urlSlug(title || "");

    console.log(slug);

    setAliasTitle(slug);
  };

  return (
    <div className="eshop-category">
      <Row justify="space-between">
        <Col md={20} lg={9}>
          <Form
            form={form}
            name="basic"
            labelCol={{ span: 8 }}
            wrapperCol={{ span: 16 }}
            initialValues={{ remember: true }}
            onFinish={onFinish}
            onFinishFailed={onFinishFailed}
            autoComplete="off"
          >
            <Form.Item
              label="Tiêu đề"
              name="title"
              rules={[
                { required: true, message: "Tên thể loại không được để trống" },
              ]}
            >
              <Input onBlur={onTitleBlur} />
            </Form.Item>

            <Form.Item label="Alias">
              <Input value={aliasTitle} />
            </Form.Item>

            <Form.Item label="Mô tả" name="description" rules={[]}>
              <Input.TextArea rows={5} />
            </Form.Item>

            <Form.Item label="Thứ tự" name="order" rules={[]}>
              <InputNumber />
            </Form.Item>

            <Form.Item
              name="showOnHomePage"
              valuePropName="checked"
              wrapperCol={{ offset: 8, span: 16 }}
            >
              <Checkbox> Hiển thị trên trang chủ </Checkbox>
            </Form.Item>

            <Form.Item wrapperCol={{ offset: 8, span: 16 }}>
              <Button type="primary" htmlType="submit">
                Thêm mới
              </Button>
            </Form.Item>
          </Form>
        </Col>
        <Col md={20} lg={14}>
          <Table columns={columns} dataSource={data} />
        </Col>
      </Row>
    </div>
  );
};

export default CategoryView;
