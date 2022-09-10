import React, { Component } from 'react';

export class Product extends Component {
  static displayName = Product.name;

  constructor(props) {
    super(props);
    this.state = { products: [], loading: true };
  }

  componentDidMount() {
    this.populateProductData();
  }

  static renderProductTable(products) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>ID</th>
            <th>Tên</th>
            <th>Giá</th>
            <th>Số lượng</th>
          </tr>
        </thead>
        <tbody>
          {products.map((p, i) =>
            <tr key={i}>
              <td>{p.id}</td>
              <td>{p.name}</td>
              <td>{p.price}</td>
              <td>{p.stock}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : Product.renderProductTable(this.state.products);

    return (
      <div>
        <h1 id="tabelLabel" >Danh sách sản phẩm</h1>
        {contents}
      </div>
    );
  }

  async populateProductData() {
    const response = await fetch('/api/product');
    const data = await response.json();

    this.setState({ products: data, loading: false });
  }
}
