

class ShoppingCart {
    constructor() {
        this.items = {}
        this.total = 0

        this.loadCartFromCookies()
        this.showCart()
    }

    showCart() {

        let cart_list = document.querySelector('.cart')
        if (cart_list) {
            cart_list.innerHTML = ''
            for (let title in this.items) {
                cart_list.innerHTML += getCartItem(this.items[title])
            }
        }

        let totalPrice = document.querySelector(".total-price")
        totalPrice.innerHTML = this.calculateTotalPrice()
    }



    addItem(item) {
        if (this.items[item.title]) {
            this.items[item.title].quantity += 1
        }
        else {
            this.items[item.title] = item
            this.items[item.title].quantity = 1
        }
        console.log(this.items)
        this.saveCartToCookies()
        this.showCart()
    }



    calculateTotalPrice() {
        let total = 0;
        for (let item in this.items) {
            total += this.items[item].price * this.items[item].quantity;
        }
        return total
    }
    saveCartToCookies() {
        let cartJSON = JSON.stringify(this.items)
        document.cookie = `cart=${cartJSON}; max-age=${60 * 60 * 24 * 7}; path=/`
    }



    loadCartFromCookies() {
        let cartCookie = getCookieValue('cart')
        if (cartCookie && cartCookie !== '') {
            this.items = JSON.parse(cartCookie)
        }
    }
}



let cart = new ShoppingCart()
function addToCart(event) {
    let productData = event.target.getAttribute('data-product')
    let product = JSON.parse(productData)
    // тут буде додавання в кошик
    cart.addItem(product)
}


function getCartItem(item) {
    return `
    <div class="card mb-3" style="max-width: 540px;">
        <div class="row g-0">
            <div class="col-md-4">
                <img src="${item.image}" class="img-fluid rounded-start" alt="...">
            </div>
            <div class="col-md-8">
                <div class="card-body">
                    <h5 class="card-title">${item.title}<h5>
                    <p class="card-text">${item.quantity}<p>
                    <p class="card-text">${item.price * item.quantity} euro</p>
                </div>
        </div>
    </div>
</div>`
}