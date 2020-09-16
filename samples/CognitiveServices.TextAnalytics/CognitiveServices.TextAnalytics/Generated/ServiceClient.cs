// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using CognitiveServices.TextAnalytics.Models;

namespace CognitiveServices.TextAnalytics
{
    /// <summary> The Service service client. </summary>
    public partial class ServiceClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ServiceRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ServiceClient for mocking. </summary>
        protected ServiceClient()
        {
        }
        /// <summary> Initializes a new instance of ServiceClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> Supported Cognitive Services endpoints (protocol and hostname, for example: https://westus.api.cognitive.microsoft.com). </param>
        /// <param name="stringIndexType"> (Optional) Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        internal ServiceClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, StringIndexType? stringIndexType = null)
        {
            RestClient = new ServiceRestClient(clientDiagnostics, pipeline, endpoint, stringIndexType);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get the status of an analysis job.  A job may consist of one or more tasks.  Once all tasks are completed, the job will transition to the completed state and results will be available for each task. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="top"> (Optional) Set the maximum number of results per task. When both $top and $skip are specified, $skip is applied first. </param>
        /// <param name="skip"> (Optional) Set the number of elements to offset in the response. When both $top and $skip are specified, $skip is applied first. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> AnalyzeStatusAsync(Guid jobId, bool? showStats = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeStatus");
            scope.Start();
            try
            {
                return await RestClient.AnalyzeStatusAsync(jobId, showStats, top, skip, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the status of an analysis job.  A job may consist of one or more tasks.  Once all tasks are completed, the job will transition to the completed state and results will be available for each task. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="top"> (Optional) Set the maximum number of results per task. When both $top and $skip are specified, $skip is applied first. </param>
        /// <param name="skip"> (Optional) Set the number of elements to offset in the response. When both $top and $skip are specified, $skip is applied first. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> AnalyzeStatus(Guid jobId, bool? showStats = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.AnalyzeStatus");
            scope.Start();
            try
            {
                return RestClient.AnalyzeStatus(jobId, showStats, top, skip, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get details of the healthcare prediction job specified by the jobId. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="top"> (Optional) Set the maximum number of results per task. When both $top and $skip are specified, $skip is applied first. </param>
        /// <param name="skip"> (Optional) Set the number of elements to offset in the response. When both $top and $skip are specified, $skip is applied first. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HealthcareJobState>> HealthStatusAsync(Guid jobId, int? top = null, int? skip = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.HealthStatus");
            scope.Start();
            try
            {
                return await RestClient.HealthStatusAsync(jobId, top, skip, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get details of the healthcare prediction job specified by the jobId. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="top"> (Optional) Set the maximum number of results per task. When both $top and $skip are specified, $skip is applied first. </param>
        /// <param name="skip"> (Optional) Set the number of elements to offset in the response. When both $top and $skip are specified, $skip is applied first. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HealthcareJobState> HealthStatus(Guid jobId, int? top = null, int? skip = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.HealthStatus");
            scope.Start();
            try
            {
                return RestClient.HealthStatus(jobId, top, skip, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of general named entities in a given document. For the list of supported entity types, check &lt;a href=&quot;https://aka.ms/taner&quot;&gt;Supported Entity Types in Text Analytics API&lt;/a&gt;. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> EntitiesRecognitionGeneralAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.EntitiesRecognitionGeneral");
            scope.Start();
            try
            {
                return await RestClient.EntitiesRecognitionGeneralAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of general named entities in a given document. For the list of supported entity types, check &lt;a href=&quot;https://aka.ms/taner&quot;&gt;Supported Entity Types in Text Analytics API&lt;/a&gt;. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> EntitiesRecognitionGeneral(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.EntitiesRecognitionGeneral");
            scope.Start();
            try
            {
                return RestClient.EntitiesRecognitionGeneral(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The API returns a list of entities with personal information (\&quot;SSN\&quot;, \&quot;Bank Account\&quot; etc) in the document. For the list of supported entity types, check &lt;a href=&quot;https://aka.ms/tanerpii&quot;&gt;Supported Entity Types in Text Analytics API&lt;/a&gt;. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages.
        /// .
        /// </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="domain"> (Optional) if specified, will set the PII domain to include only a subset of the entity categories. Possible values include: &apos;PHI&apos;, &apos;none&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> EntitiesRecognitionPiiAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, string domain = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.EntitiesRecognitionPii");
            scope.Start();
            try
            {
                return await RestClient.EntitiesRecognitionPiiAsync(input, modelVersion, showStats, domain, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The API returns a list of entities with personal information (\&quot;SSN\&quot;, \&quot;Bank Account\&quot; etc) in the document. For the list of supported entity types, check &lt;a href=&quot;https://aka.ms/tanerpii&quot;&gt;Supported Entity Types in Text Analytics API&lt;/a&gt;. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages.
        /// .
        /// </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="domain"> (Optional) if specified, will set the PII domain to include only a subset of the entity categories. Possible values include: &apos;PHI&apos;, &apos;none&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> EntitiesRecognitionPii(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, string domain = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.EntitiesRecognitionPii");
            scope.Start();
            try
            {
                return RestClient.EntitiesRecognitionPii(input, modelVersion, showStats, domain, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of recognized entities with links to a well-known knowledge base. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> EntitiesLinkingAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.EntitiesLinking");
            scope.Start();
            try
            {
                return await RestClient.EntitiesLinkingAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of recognized entities with links to a well-known knowledge base. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> EntitiesLinking(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.EntitiesLinking");
            scope.Start();
            try
            {
                return RestClient.EntitiesLinking(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of strings denoting the key phrases in the input text. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> KeyPhrasesAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.KeyPhrases");
            scope.Start();
            try
            {
                return await RestClient.KeyPhrasesAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a list of strings denoting the key phrases in the input text. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> KeyPhrases(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.KeyPhrases");
            scope.Start();
            try
            {
                return RestClient.KeyPhrases(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns the detected language and a numeric score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> LanguagesAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Languages");
            scope.Start();
            try
            {
                return await RestClient.LanguagesAsync(input, modelVersion, showStats, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns the detected language and a numeric score between 0 and 1. Scores close to 1 indicate 100% certainty that the identified language is true. See the &lt;a href=&quot;https://aka.ms/talangs&quot;&gt;Supported languages in Text Analytics API&lt;/a&gt; for the list of enabled languages. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> Languages(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Languages");
            scope.Start();
            try
            {
                return RestClient.Languages(input, modelVersion, showStats, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a detailed sentiment analysis for the input text. The analysis is done in multiple levels of granularity, start from the a document level, down to sentence and key terms (aspects) and opinions. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="opinionMining"> (Optional) if set to true, response will contain input and document level statistics including aspect-based sentiment analysis results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> SentimentAsync(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, bool? opinionMining = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Sentiment");
            scope.Start();
            try
            {
                return await RestClient.SentimentAsync(input, modelVersion, showStats, opinionMining, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The API returns a detailed sentiment analysis for the input text. The analysis is done in multiple levels of granularity, start from the a document level, down to sentence and key terms (aspects) and opinions. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="showStats"> (Optional) if set to true, response will contain request and document level statistics. </param>
        /// <param name="opinionMining"> (Optional) if set to true, response will contain input and document level statistics including aspect-based sentiment analysis results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> Sentiment(MultiLanguageBatchInput input, string modelVersion = null, bool? showStats = null, bool? opinionMining = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.Sentiment");
            scope.Start();
            try
            {
                return RestClient.Sentiment(input, modelVersion, showStats, opinionMining, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a collection of text documents for analysis. Specify one or more unique tasks to be executed. </summary>
        /// <param name="body"> Collection of documents to analyze and tasks to execute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ServiceAnalyzeOperation> StartAnalyzeAsync(AnalyzeBatchInput body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.StartAnalyze");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.AnalyzeAsync(body, cancellationToken).ConfigureAwait(false);
                return new ServiceAnalyzeOperation(_clientDiagnostics, _pipeline, RestClient.CreateAnalyzeRequest(body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Submit a collection of text documents for analysis. Specify one or more unique tasks to be executed. </summary>
        /// <param name="body"> Collection of documents to analyze and tasks to execute. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ServiceAnalyzeOperation StartAnalyze(AnalyzeBatchInput body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.StartAnalyze");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Analyze(body, cancellationToken);
                return new ServiceAnalyzeOperation(_clientDiagnostics, _pipeline, RestClient.CreateAnalyzeRequest(body).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel healthcare prediction job. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ServiceCancelHealthJobOperation> StartCancelHealthJobAsync(Guid jobId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.StartCancelHealthJob");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CancelHealthJobAsync(jobId, cancellationToken).ConfigureAwait(false);
                return new ServiceCancelHealthJobOperation(_clientDiagnostics, _pipeline, RestClient.CreateCancelHealthJobRequest(jobId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel healthcare prediction job. </summary>
        /// <param name="jobId"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ServiceCancelHealthJobOperation StartCancelHealthJob(Guid jobId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ServiceClient.StartCancelHealthJob");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CancelHealthJob(jobId, cancellationToken);
                return new ServiceCancelHealthJobOperation(_clientDiagnostics, _pipeline, RestClient.CreateCancelHealthJobRequest(jobId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Start a healthcare analysis job to recognize healthcare related entities (drugs, conditions, symptoms, etc) and their relations. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual async Task<ServiceHealthOperation> StartHealthAsync(MultiLanguageBatchInput input, string modelVersion = null, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceClient.StartHealth");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.HealthAsync(input, modelVersion, cancellationToken).ConfigureAwait(false);
                return new ServiceHealthOperation(_clientDiagnostics, _pipeline, RestClient.CreateHealthRequest(input, modelVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Start a healthcare analysis job to recognize healthcare related entities (drugs, conditions, symptoms, etc) and their relations. </summary>
        /// <param name="input"> Collection of documents to analyze. </param>
        /// <param name="modelVersion"> (Optional) This value indicates which model will be used for scoring. If a model-version is not specified, the API should default to the latest, non-preview version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="input"/> is null. </exception>
        public virtual ServiceHealthOperation StartHealth(MultiLanguageBatchInput input, string modelVersion = null, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var scope = _clientDiagnostics.CreateScope("ServiceClient.StartHealth");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Health(input, modelVersion, cancellationToken);
                return new ServiceHealthOperation(_clientDiagnostics, _pipeline, RestClient.CreateHealthRequest(input, modelVersion).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
