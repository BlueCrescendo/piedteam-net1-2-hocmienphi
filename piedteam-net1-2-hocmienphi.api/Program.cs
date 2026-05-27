var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
        

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecast
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    summaries[Random.Shared.Next(summaries.Length)]
                ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();

//kiến trúc 3 Layer.

//Tầng API
    //CHỊU TRÁCH NHIỆM KHAI BÁO CÁC ENDPOINT,
    //nhận request, trả response
    //Tầng API này gọi tới Service

//config hệ thống
//TẦNG service
        //Chịu trách nhiệm xử lý nghiệp vụ
        //Tương tác với tầng Repositary để lấy dữ liệu
        //Tầng Service gọi tới Repository
//Tâầng Repositry
    //Chịu trách nhiệm tương tác với database
    //Cấu hình những thứ liên quan tới database


//A có 1 cái req f đăng nhập vào hệ thống
        //Tầng API: Muốn đăng nhập vào hệ thống á
        //Chui vô đây nè: POST /api/auth/login
            //Nhận request body (emai;: "tan", password: "123"}
        //Tầng API úc này gọi xuống tầng service có cái hàm là
            //Xử lý login LoginHAndler(email, password)
            //Lúc này hàm login trong Service hãy chạy như sau
                //Kiểm tra email này có tồn tại trong database hay không
                //Người dùng này có bị banned hay không
                //Nếu có lỗi thì trả về lỗi
                //Nếu không có lỗi thì trả vể Token đăng nhập
//Tầng Servir lúc này gọi xuống tầng Repository có cái hàm gọi là 
//GetUserByEmail(email)
//Hàm này sẽ chạy câu lệnh SQL để
//lấy thông tin người dùng ra khỏi Databáe
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}