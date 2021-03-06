// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/account.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ServerFoS {
  public static partial class Account
  {
    static readonly string __ServiceName = "Account.Account";

    static readonly grpc::Marshaller<global::ServerFoS.LoginResponse> __Marshaller_Account_LoginResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ServerFoS.LoginResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse> __Method_Login = new grpc::Method<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_Account_LoginResponse,
        __Marshaller_Account_LoginResponse);

    static readonly grpc::Method<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse> __Method_CreateAccount = new grpc::Method<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateAccount",
        __Marshaller_Account_LoginResponse,
        __Marshaller_Account_LoginResponse);

    static readonly grpc::Method<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse> __Method_RemoveAccount = new grpc::Method<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RemoveAccount",
        __Marshaller_Account_LoginResponse,
        __Marshaller_Account_LoginResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ServerFoS.AccountReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Account</summary>
    [grpc::BindServiceMethod(typeof(Account), "BindService")]
    public abstract partial class AccountBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ServerFoS.LoginResponse> Login(global::ServerFoS.LoginResponse request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServerFoS.LoginResponse> CreateAccount(global::ServerFoS.LoginResponse request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::ServerFoS.LoginResponse> RemoveAccount(global::ServerFoS.LoginResponse request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Account</summary>
    public partial class AccountClient : grpc::ClientBase<AccountClient>
    {
      /// <summary>Creates a new client for Account</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccountClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Account that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccountClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccountClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccountClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ServerFoS.LoginResponse Login(global::ServerFoS.LoginResponse request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Login(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServerFoS.LoginResponse Login(global::ServerFoS.LoginResponse request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Login, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServerFoS.LoginResponse> LoginAsync(global::ServerFoS.LoginResponse request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LoginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServerFoS.LoginResponse> LoginAsync(global::ServerFoS.LoginResponse request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Login, null, options, request);
      }
      public virtual global::ServerFoS.LoginResponse CreateAccount(global::ServerFoS.LoginResponse request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServerFoS.LoginResponse CreateAccount(global::ServerFoS.LoginResponse request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateAccount, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServerFoS.LoginResponse> CreateAccountAsync(global::ServerFoS.LoginResponse request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServerFoS.LoginResponse> CreateAccountAsync(global::ServerFoS.LoginResponse request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateAccount, null, options, request);
      }
      public virtual global::ServerFoS.LoginResponse RemoveAccount(global::ServerFoS.LoginResponse request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ServerFoS.LoginResponse RemoveAccount(global::ServerFoS.LoginResponse request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RemoveAccount, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ServerFoS.LoginResponse> RemoveAccountAsync(global::ServerFoS.LoginResponse request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RemoveAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ServerFoS.LoginResponse> RemoveAccountAsync(global::ServerFoS.LoginResponse request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RemoveAccount, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AccountClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccountClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AccountBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Login, serviceImpl.Login)
          .AddMethod(__Method_CreateAccount, serviceImpl.CreateAccount)
          .AddMethod(__Method_RemoveAccount, serviceImpl.RemoveAccount).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AccountBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Login, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse>(serviceImpl.Login));
      serviceBinder.AddMethod(__Method_CreateAccount, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse>(serviceImpl.CreateAccount));
      serviceBinder.AddMethod(__Method_RemoveAccount, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ServerFoS.LoginResponse, global::ServerFoS.LoginResponse>(serviceImpl.RemoveAccount));
    }

  }
}
#endregion
